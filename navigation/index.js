import React from 'react';
import {Image} from 'react-native';
import {createAppContainer,createStackNavigator} from 'react-navigation';

import Welcome from '../screens/Welcome';
// import Login from '../screens/Welcome';
// import Explore from '../screens/Welcome';
// import Browse from '../screens/Welcome';
// import Product from '../screens/Welcome';
// import Settings from '../screens/Welcome';

import {theme} from '../constants';

const screens = createStackNavigator({
    Welcome,
    // Login,
    // Explore,
    // Browse,
    // Product,
    // Settings,
},
{
    defaultNavigationOptions:{
        headerStyle:{},
        headerBackImage:<Image/>,
        headerBackTitle:null,
        headerLeftContainerStyle:{},
        headerRightContainerStyle:{},
    }
});

export default createAppContainer(screens);